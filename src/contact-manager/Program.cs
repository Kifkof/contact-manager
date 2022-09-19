﻿using System.Diagnostics;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Views;

namespace contact_manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var formFactory = new DefaultFormFactory();

            //TODO TraineeDetailDialog: GroupBox für Lernende renamen und verschieben (Cosimo)
            //TODO CSV File für Lernende erstellen (Cosimo)
            //TODO Enums in Grid Feldern auf Deutsch (Cosimo)
            //TODO Mitarbeiternummer evtl. schlauer vergeben (Cosimo)
            //TODO Dialoge schliessen beim speichern -> Eintrag in Grid auswählen nach schliessen (Cosimo)
            //TODO Enable/Disable in Dialogen evtl. refactoren (Cosimo)
            //TODO try catch mit MessageBox um Applikation um abstürtze zu verhindern (Cosimo)
            //TODO Unklarheiten Dokumentieren und Kommentieren in Search-Domäne (Päddy)
            //TODO Entfernen Debugging Login(Cosimo)

            //TODO Code Cleanup (Cosimo)
            //TODO Ausführliches Testing mit Fixes (Cosimo)
            //TODO Klassendiagram (Cosimo)
            //TODO Stundenprotokoll vervollstädigen
            //TODO Text-Datei mit Applikationsbeschreib (Vorschlag: Cosimo, Review/Ergänzungen: Päddy/Luca)

            if (Debugger.IsAttached)
            {
                var overviewView = formFactory.CreateOverview(Users.AdminUser);
                Application.Run(overviewView);
            }
            else
            {
                var loginForm = formFactory.CreateLoginDialog();
                Application.Run(loginForm);
            }
        }
    }
}
