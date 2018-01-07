using System.Linq;

class BsSchowek {

[System.STAThreadAttribute]
public static int Main(string[] args) {
  if (args.Length==0) {
    System.Console.WriteLine("uzycie: CmdHere katalog");
    System.Console.WriteLine("wersja .NET: " + System.Environment.Version);
    return 1;
    }
  else {
    string s = args[0];
    System.Console.WriteLine("arg: " + s);
    var f = new System.IO.FileInfo(s);
    var dir = f.Directory.FullName;
    System.Console.WriteLine("parent: " + dir);
    var cmdArgs = new string[] {
      "/c",
      "start",
      "\"CmdHere\"",
      "/D", "\"" + dir + "\"",
      "cmd.exe"
    };
    var cmdArgsStr = string.Join(" ", cmdArgs.ToList());
    System.Console.WriteLine("cmd.exe args: " + cmdArgsStr);
    System.Diagnostics.Process.Start(@"cmd.exe", cmdArgsStr);
    return 0;
    }
  }

}
