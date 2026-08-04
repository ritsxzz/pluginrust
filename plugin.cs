using System;
using BepInEx;
using UnityEngine;
// Обязательно добавь эти строки, где живет ConsoleSystem:
using Network;
using Apex;
namespace MyCustomPlugin
{
    [BepInPlugin("com.myproject.serverconnector", "Server Connector", "1.0.0")]
    public class ServerConnectorPlugin : BaseUnityPlugin
    {
        private const string ServerIP = "217.60.245.104";
        private const int ServerPort = 20000;

        void OnGUI()
        {
            // Отрисовка простой кнопки прямо в меню игры
            if (GUI.Button(new Rect(10, 10, 200, 40), "Подключиться к серверу"))
            {
                ConnectToServer();
            }
        }

        private void ConnectToServer()
        {
            // Вызов встроенной консольной команды Rust для подключения
            ConsoleSystem.Run(ConsoleSystem.Option.Client, $"connect {ServerIP}:{ServerPort}");
        }
    }
}
