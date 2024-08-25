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
