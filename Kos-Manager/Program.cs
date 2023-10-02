﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos_Manager
{

    public static class Fornecedor
    {
        public static string Nome { get; set; }
        public static string Produto { get; set; }
        public static string Contato { get; set; }
        public static string Outro { get; internal set; }
    }

    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tela_splash());
        }
    }
}
