// Decompiled with JetBrains decompiler
// Type: agnks.figures
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System.Windows.Forms;

namespace agnks
{
  public class figures
  {
    public static string Point(string s)
    {
      return s.Replace(',', '.');
    }

    public static void TestingFigures(TextBox figure)
    {
      int num1 = 0;
      string str = figure.Text.Replace('.', ',');
      figure.Text = str;
      figure.SelectionStart = figure.TextLength;
      for (int index = 0; index < figure.Text.Length; ++index)
      {
        switch (figure.Text[index])
        {
          case ',':
            ++num1;
            if (num1 > 1)
            {
              figure.Text = "";
              num1 = 0;
              continue;
            }
            continue;
          case '0':
          case '1':
          case '2':
          case '3':
          case '4':
          case '5':
          case '6':
          case '7':
          case '8':
          case '9':
            continue;
          default:
            int num2 = (int) MessageBox.Show(figure.Name + " Введите число!");
            figure.Text = "";
            continue;
        }
      }
      if (!(figure.Text == ","))
        return;
      figure.Text = "";
    }
  }
}
