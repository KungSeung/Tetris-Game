using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum TBlock
{
	WALL,	//0
	VOID,	//1 , 값을 넣어주고 싶으면 Jeju = 5
	BLOCK,
}

public class Test
{

}

namespace Tetris
{
	class Program
	{
		static void Main(string[] args)
		{
			TScreen NewSC = new TScreen(10, 15);

			Block NewBlcok = new Block();

			for (int y = 0; y < 3; ++y)
			{
				for (int x = 0; x < 3; ++x)
				{
					NewSC.SetBlock(y, x, TBlock.WALL);
				}
			}

			//NewSC.SetBlock(3, 3, TBlock.WALL);

			NewSC.Render();
			
			Console.ReadKey();
			
		}
	}
}
