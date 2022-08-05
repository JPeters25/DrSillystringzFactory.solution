using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int PlanetId { get; set; }
    public string Name { get; set; }
    public int Distance { get ; set; }
    public string Weather { get; set; }
    public int Temperature { get; set; }
    public int Radiation { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }

    }
  }
