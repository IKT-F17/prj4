using System;
using System.Collections.Generic;
using System.Text;

namespace Highscore

public class Mapname
{
    public int MapScore { get; set; }
}

public class Name
{
    public Mapname Mapname { get; set; }
    public int THS { get; set; }
}

public class PH
{
    public Name Name { get; set; }
}

public class Mapname2
{
    public int MapScore { get; set; }
}

public class Name3
{
    public Mapname2 Mapname { get; set; }
    public int THS { get; set; }
}

public class PH2
{
    public Name3 Name { get; set; }
}

public class Name2
{
    public List<PH2> PHS { get; set; }
}

public class H
{
    public Name2 Name { get; set; }
}

public class Name4
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class User
{
    public Name4 Name { get; set; }
}

public class MapName3
{
    public string filepath { get; set; }
}

public class IMap
{
    public MapName3 MapName { get; set; }
}

public class RootObject
{
    public List<PH> PHS { get; set; }
    public List<H> HS { get; set; }
    public List<User> Users { get; set; }
    public List<IMap> IMap { get; set; }
}

