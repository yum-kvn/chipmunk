using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChipListParts : BaseUIParts
{
	[SerializeField]
	private List<ChipParts> chipPartsLists;

	public System.Action<int, BaseChip> chipPartsClick;

	public void SetChips(List<BaseChip> chips)
	{
		RemoveAllChip();

		int index = 0;
		foreach (BaseChip chip in chips)
		{
			ChipParts chipParts = chipPartsLists[index];
			chipParts.SetChip(chip);

			index++;
		}

		UpdateAllChip();
	}

	public void UpdateAllChip()
	{
		foreach (ChipParts parts in chipPartsLists)
		{
			parts.UpdateParts();
		}
	}

	public void RemoveAllChip()
	{
		foreach (ChipParts parts in chipPartsLists)
		{
			parts.RemoveChip();
		}
	}

	public void ChipClick(ChipParts parts)
	{
		chipPartsClick(chipPartsLists.IndexOf(parts), parts.GetChip());
	}
}
