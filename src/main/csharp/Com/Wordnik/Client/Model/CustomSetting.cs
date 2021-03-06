using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class CustomSetting {
    public List<string> name { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomSetting {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
