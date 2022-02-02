// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Net.NetworkInformation;


IPAddress GetIPAddress()
{
    
    Ping ping = new Ping();
    var replay = ping.Send("www.google.com");

    if (replay.Status == IPStatus.Success)
    {
        return replay.Address;
    }
    return null;
 }

System.Console.WriteLine("ip Adress: "+GetIPAddress()); 
