using MineSweeper.Interface;

namespace MineSweeper
{
	public class Block
	{
		public string BlockType { get; set; }
		public bool IsTriggered { get; init; }
		public bool IsMarked { get; set; }
		public List<Block> AdjacentBlocks { get; init; } = new List<Block>();
		public uint AdjacentMines { get; set; }
	}
}
