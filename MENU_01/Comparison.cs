using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MENU_01
{
	public class Comparison
	{
		// sets the construstor for writing to file
		string fileName;
		public Comparison(string FileName)
		{
			// sets the constructor as a variable
			fileName = FileName;
		}

		// writes the items to the text file 
		public void Write(Order order)
		{
			using (StreamWriter sr = new StreamWriter(fileName))
			{// opens the file and write in it
				foreach (var item in order.Selecteditems)
				{
					// writes if the items variable 
					if (item != null)
					{
						// writes from the items variable into the text file
						sr.WriteLine(item);
					}
					
				}
				// closes the file after usage
				sr.Close();
			}
			
		}


    }
}
		