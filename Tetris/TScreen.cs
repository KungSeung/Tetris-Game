using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TScreen
{
	List<List<TBlock>> BlockList = new List<List<TBlock>>();

	public void SetBlock(int _y, int _x, TBlock _Type)
	{
		BlockList[_y][_x] = _Type;
	}

	public void Render()
	{
		for (int y = 0; y < BlockList.Count; ++y)
		{
			for (int x = 0; x < BlockList[y].Count; ++x)
			{
				switch (BlockList[y][x])
				{
					case TBlock.WALL:
						Console.Write("▣");
						break;
					case TBlock.VOID:
						Console.Write("□");
						break;
					case TBlock.BLOCK:
						Console.Write("■");
						break;
					default:
						break;
				}
			}
			Console.WriteLine();
		}
	}

	public void TetrissScreen(int _X, int _Y)
	{
		for (int y = 0; y < _Y; y++)
		{
			BlockList.Add(new List<TBlock>());
			for (int x = 0; x < _X; ++x)
			{
				BlockList[y].Add(TBlock.VOID);
			}
		}

		//첫번째 줄
		for (int i = 0; i < BlockList[0].Count; i++)
		{
			BlockList[0][i] = TBlock.WALL;
		}
		//마지막 줄
		for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
		{
			BlockList[BlockList.Count - 1][i] = TBlock.WALL;
		}
	}
}

