using System.Management;
using System.Net;
using System.Net.NetworkInformation;



namespace NetConfig
{
    class NetMC
    {
        public static string IPAdress, gateaddress, DnsAddress1, DnsAddress2;
        
        public static void GetIP()
        {
            try
            {
                string hname = Dns.GetHostName();

                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (var adapter in interfaces)
                {
                    foreach (var ip in adapter.GetIPProperties().UnicastAddresses)
                    {
                        IPAdress = ip.Address.ToString();
                    }                    
                    foreach (var gateway in adapter.GetIPProperties().GatewayAddresses)
                    {
                        gateaddress = gateway.Address.ToString();
                    }
                    foreach (var dns in adapter.GetIPProperties().DnsAddresses)
                    {
                        DnsAddress1 += dns.ToString();
                        DnsAddress2 += dns.Address.ToString();
                    }
                    return;
                }              
                
            }
            catch
            {

            }
            
            
            
        }
        
        public static void SetIP(string ip, string submask)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject SetDHCP;
                        ManagementBaseObject newIP = mo.GetMethodParameters("EnableStatic");
                        

                        newIP["IPAddress"] = new string[] { ip };
                        newIP["SubnetMask"] = new string[] { submask };
                      
                        
                        SetDHCP = mo.InvokeMethod("EnableStatic", newIP, null);

                    }
                    catch
                    {
                        throw;
                    }
                }
            }

        }

        public static void setGateway(string gateway)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setgateway;
                        ManagementBaseObject newgateway = mo.GetMethodParameters("SetGateways");

                        newgateway["DefaultIPGateway"] = new string[] { gateway };
                        newgateway["GatewayCostMetric"] = new int[] { 1 };

                        setgateway = mo.InvokeMethod("SetGateways", newgateway, null);
                        
                    }
                    catch
                    {
                        throw;
                    }
                }

                
            }
        }
        
        public static void setDNS(string dns)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

           
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"])
                    {

                        ManagementBaseObject setDNS;
                        ManagementBaseObject newDNS = mo.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = dns.Split(',');

                        setDNS = mo.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);

                    }
                }
            }
            

            
        
        

       /* public static ArrayList GetNic()
        {
            ArrayList NIC = new ArrayList();
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    NIC.Add(mo["Caption"]);
                }
            }

            return NIC;
        }
        */


    }
}




	/*

//Рефакторинг кода из balexandre немного, так объекты получает утилизировать и новые возможности языка C# 3.5+ (Linq, var, etc). Также переименованы переменные для более осмысленные имена. Я также объединены некоторые функции, чтобы быть в состоянии сделать больше, конфигурации с меньшей WMI взаимодействия. Я удалил WINS-код, как мне не нужно, чтобы настроить WINS больше. Не стесняйтесь добавлять WINS-код, если это необходимо.

//Для случая, кто любит использовать рефакторинг/модернизированный код я положил его обратно в сообщество здесь.

/// <summary>
/// Helper class to set networking configuration like IP address, DNS servers, etc.
/// </summary>
public class NetworkConfigurator
{
    /// <summary>
    /// Set's a new IP Address and it's Submask of the local machine
    /// </summary>
    /// <param name="ipAddress">The IP Address</param>
    /// <param name="subnetMask">The Submask IP Address</param>
    /// <param name="gateway">The gateway.</param>
    /// <remarks>Requires a reference to the System.Management namespace</remarks>
    public void SetIP(string ipAddress, string subnetMask, string gateway)
    {
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    using (var newIP = managementObject.GetMethodParameters("EnableStatic"))
                    {
                        // Set new IP address and subnet if needed
                        if ((!String.IsNullOrEmpty(ipAddress)) || (!String.IsNullOrEmpty(subnetMask)))
                        {
                            if (!String.IsNullOrEmpty(ipAddress))
                            {
                                newIP["IPAddress"] = new[] { ipAddress };
                            }

                            if (!String.IsNullOrEmpty(subnetMask))
                            {
                                newIP["SubnetMask"] = new[] { subnetMask };
                            }

                            managementObject.InvokeMethod("EnableStatic", newIP, null);
                        }

                        // Set mew gateway if needed
                        if (!String.IsNullOrEmpty(gateway))
                        {
                            using (var newGateway = managementObject.GetMethodParameters("SetGateways"))
                            {
                                newGateway["DefaultIPGateway"] = new[] { newGateway };
                                newGateway["GatewayCostMetric"] = new[] { 1 };
                                managementObject.InvokeMethod("SetGateways", newGateway, null);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// Set's the DNS Server of the local machine
    /// </summary>
    /// <param name="nic">NIC address</param>
    /// <param name="dnsServers">Comma seperated list of DNS server addresses</param>
    /// <remarks>Requires a reference to the System.Management namespace</remarks>
    public void SetNameservers(string nic, string dnsServers)
    {
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(objMO => (bool)objMO["IPEnabled"] && objMO["Caption"].Equals(nic)))
                {
                    using (var newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                    {
                        newDNS["DNSServerSearchOrder"] = dnsServers.Split(',');
                        managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                }
            }
        }
    }
}
*/