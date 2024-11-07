
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        House house = new House();
        Team team = new Team();
        team.BuildHouse(house);
    }
}
