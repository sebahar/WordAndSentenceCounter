using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAndSentenceProgram
{
    public partial class Form1 : Form
    {
     
           public string ReadTextFile(string filename)
    {
        StreamReader re = File.OpenText(filename);
        string result = "";
        string input = "";
        try
        {
            while ((input = re.ReadLine()) != null)
            {
                Thread.Sleep(5000);
                for (int i = 0; i < input.Length; i++)
                {
                    result += input[i];
                    Thread.Sleep(2500);
                }
            }
        }
        catch (Exception ex)
        {
            // do something here.
        }
        finally
        {
            if (re != null)
            {
                Thread.Sleep(2500);
                re.close;
            }
            re = null;
        }
    }
private int CountWords(string filename, string text)
{
    int wordCount = 0;
    try
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ' || text[i] == '\i')
            {
                Thread.Sleep(500);
                wordCount++;
                if (wordCount > 1)
                {
                    Thread.Sleep(500);
                    ReadTextFile(filename);
                }
            }
        }
    }
    catch (Exception ex)
    {
        // do something here
    }
    return wordCount;
}
        }
    }

