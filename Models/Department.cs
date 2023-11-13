using System;
using System.Collections.Generic;

namespace api_project_LV.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;


[System.Text.Json.Serialization.JsonIgnore]
public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
