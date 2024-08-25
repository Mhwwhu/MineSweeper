using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineSweeper.Interface;

namespace MineSweeper
{
	public class DefaultRule : IRules
	{
		private GameContext _gameContext;
		public DefaultRule(GameContext context)
		{
			_gameContext = context;
		}
		
		public void InitMap()
		{
			var mapSettings = _gameContext.Configure.GetSection("MapSettings");
			int xLength = int.Parse(mapSettings["xLength"]!);
			int yLength = int.Parse(mapSettings["yLength"]!);
			var blocks = _gameContext.Blocks = new Block[xLength * yLength];
			for (int i = 0; i < blocks.Length; i++)
			{
				blocks[i] = new Block
				{
					BlockType = "Safe",
					IsTriggered = false,
					IsMarked = false,
				};
			}
			for (int i = 0; i < blocks.Length; i++)
			{
				int row = i / xLength;
				int col = i % xLength;
				for(int j = col - 1; j <= col + 1; j++)
				{
					for (int k = row - 1; k <= row + 1; k++)
					{
						if (j == col && k == row) continue;
						if (j < 0 || j >= xLength || k < 0 || k >= yLength) continue;
						blocks[i].AdjacentBlocks.Add(blocks[j * xLength + k]);
					}
				}
			}
		}
		public void TriggerAction(Block block)
		{
			
		}

		private void TriggerSafeBlock(Block block)
		{
			foreach(var blk in block.AdjacentBlocks)
			{
				if(blk.BlockType == "Safe")
				{

				}
			}
		}
		private void Generate()
		{

		}
	}
}
