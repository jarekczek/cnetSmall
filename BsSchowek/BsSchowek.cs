class BsSchowek {

[System.STAThreadAttribute]
public static int Main(string[] args) {
  if (args.Length==0) {
    System.Console.WriteLine("uzycie: BsSchowek tekst do umieszczenia w schowku");
    System.Console.WriteLine("wersja .NET: " + System.Environment.Version);
    return 1;
    }
  else {
    string s = "";
    for (int i=0; i<args.Length; i++) {
      if (i>0) { s += " "; }
      s += args[i];
      }
    //System.Console.WriteLine(s);
    System.Windows.Forms.Clipboard.Clear();
    bool bOk = false;
    int cTry = 1;
    while (!bOk && cTry>0) {
      try {
        //System.Windows.Forms.Clipboard.SetDataObject(s, true);
        System.Windows.Forms.Clipboard.SetText(s);
        bOk = true;
        }
      catch (System.Exception) { cTry--; }
      }
    if (!bOk) { System.Console.Error.WriteLine("Operacja nie powiodla sie"); }
    //System.Windows.Forms.Clipboard.SetDataObject(s, true);
    //System.Windows.Forms.Clipboard.SetText(s);
    return 0;
    }
  }

}
