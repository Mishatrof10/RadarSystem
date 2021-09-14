﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadarSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ShipConfiguration> Ships = new List<ShipConfiguration>();
        GlobalPositionSystem GPS = new GlobalPositionSystem();
        public MainWindow()
        {
            SelectorShip();
            InitializeComponent();
        }

        public void SetGPSCord()
        {
            GPS.SetGPS(15,15);
        }
        public void SelectorShip()
        {
            Ships.Add(new ShipConfiguration(GPS, 0, "Ship1"));
        }
    }
}
