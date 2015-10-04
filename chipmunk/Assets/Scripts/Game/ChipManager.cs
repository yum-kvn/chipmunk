using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChipManager : GameMonoBehaviour
{
	private ChipListParts chipListParts;
	private ChipSelectParts chipSelectParts;

	private List<BaseChip> originalChipDeck = new List<BaseChip>();
	private List<BaseChip> currentChipDeck = new List<BaseChip>();

	public void Init()
	{
	}

	public void SetUIParts(ChipListParts chipListParts, ChipSelectParts chipSelectParts)
	{
		this.chipListParts = chipListParts;
		chipListParts.chipPartsClick += ChipPartsClick;
		UpdateChipParts();

		this.chipSelectParts = chipSelectParts;
		ResetChipSelectParts();
	}

	public void ResetChipSelectParts()
	{
		chipSelectParts.ResetFocus();
	}

	public void UpdateChipParts()
	{
		chipListParts.SetChips(SelectChipsFromDeck());
	}

	public List<BaseChip> SelectChipsFromDeck()
	{
		// For test
		List<BaseChip> chips = new List<BaseChip>(){
			Chip.GetBaseChip(0),
			Chip.GetBaseChip(1),
			Chip.GetBaseChip(2),
			Chip.GetBaseChip(3),
			Chip.GetBaseChip(4),
		};
		return chips;
	}

	public void UpdateDeck()
	{

	}

	private void ChipPartsClick(int chipIndex, BaseChip chip)
	{
		chipSelectParts.SetChipToFocusSelectParts(chipIndex, chip);
	}
}
