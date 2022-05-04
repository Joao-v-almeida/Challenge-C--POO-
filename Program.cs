using System;
using Characters;

Wizard wizard = new Wizard("Jennica", 24, "White Wizard");

Console.WriteLine(wizard.Attack());
Console.WriteLine(wizard.Attack(20));