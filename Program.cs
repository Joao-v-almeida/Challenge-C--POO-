﻿using System;
using Characters;

Boss crocodile = new Boss("Crocodile", 50, "Hard Boss");
Wizard jennica = new Wizard("Jennica", 24, "White Wizard");

// Jennica Attack.
Console.WriteLine(jennica.Attack());

// Crocodile Special Attack.
Console.WriteLine(crocodile.SpecialAttack(250));