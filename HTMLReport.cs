// Decompiled with JetBrains decompiler
// Type: agnks.HTMLReport
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;

namespace agnks
{
  public class HTMLReport
  {
    public static string GetTitle(string title, string caption, string timestart, string timeend)
    {
      string str = DateTime.Now.ToLongDateString() + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
      return "<HTML><HEAD><TITLE>" + title + "</TITLE></HEAD><BODY style=\"font-size: 0\">" + ("<table Border=1 width = 80% ><caption>" + caption + "<br>c " + timestart + " по " + timeend + "<br>составленный " + str + "</caption>");
    }

    public static string GetHeadRow()
    {
      return " <tr  ALIGN=middle>\r\n\t\t\t\t\t\t<td  ALIGN=middle>Дата<br>заправки</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>Пост</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>Предприятие</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>Цена,<br>грн</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>Объём,<br>нм3</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>Стоимость,<br>грн</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>Номер<br>машины</td>\r\n\t\t\t\t\t</tr>";
    }

    public static string GetRow(
      string data,
      string post,
      string works,
      string price,
      string volume,
      string cost,
      string oper,
      string car,
      string density)
    {
      if (works == "")
        works = "(нет)";
      return " <tr>\r\n\t\t\t\t\t\t<td  ALIGN=middle>" + data + "</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>" + post + "</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>" + works + "</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>" + price + "</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>" + volume + "</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>" + cost + "</td>\r\n\t\t\t\t\t\t<td  ALIGN=middle>" + car + "</td>\r\n\t\t\t\t\t</tr>";
    }

    public static string GetTotalRow(string numzap, string vol, string cost)
    {
      return "<tr>\r\n\t\t\t\t\t\t<td><pre> </pre></td>\r\n\t\t\t\t\t\t<td colspan=2 ALIGN=middle>Количество заправок</td>\r\n\t\t\t\t\t\t<td colspan=2 ALIGN=middle>Объём заправленного газа, нм3</td>\r\n\t\t\t\t\t\t<td colspan=2 ALIGN=middle>Заправленно на сумму, грн</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td ALIGN=middle>Итого</td>\r\n\t\t\t\t\t\t<td colspan=2 ALIGN=middle>" + numzap + "</td>\r\n\t\t\t\t\t\t<td colspan=2 ALIGN=middle>" + vol + "</td>\r\n\t\t\t\t\t\t<td colspan=2 ALIGN=middle>" + cost + "</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t";
    }

    public static string GetEnd()
    {
      return "</table></body><html>";
    }
  }
}
