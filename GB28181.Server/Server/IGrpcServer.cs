﻿
namespace GB28181.Service
{
    public interface IGrpcServer
    {
        void AddIPAdress(string ipaddress);

        void AddPort(int port);

        void Run();

    }
}
