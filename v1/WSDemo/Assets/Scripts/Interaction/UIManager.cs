using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

	public static UIManager m_Instance;

	public TMP_Text captionsText;

	public GameObject handCursor;
	public GameObject backImage;

	public Image interactionImage;
	public Image numberImage;

	public GameObject inventoryImage;
	public TMP_Text[] inventoryItens;
	public TMP_Text infoText;

	public GameObject hat;
	public GameObject umbrella;

	public GameObject gem;
	public GameObject moon;
	public GameObject car;
	public GameObject controller;
	public GameObject apple;
	public GameObject candy;

	public Fungus.Flowchart m_Flowchart; // Link the Flowchart in your script

	public List<Sprite> diceNumbers;

	private void Awake()
	{
		m_Instance = this;
		DontDestroyOnLoad(gameObject);
	}
    private void Start()
    {
		numberImage.enabled = false;

	}
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.I))
		{
			ShowInventory();
		}
    }

	public void ShowInventory()
    {
		inventoryImage.SetActive(!inventoryImage.activeInHierarchy);
	}

	public void SetCaptions(string text)
	{
		captionsText.text = text;
	}

	public void SetHandCursor(bool state)
	{
		handCursor.SetActive(state);
	}

	public void SetBackImage(bool state)
	{
		backImage.SetActive(state);

		if (!state)
		{
			interactionImage.enabled = false;
		}
	}

	public void SetImage(Sprite sprite)
	{
		interactionImage.sprite = sprite;
		interactionImage.enabled = true;
	}

	public void SetNumberImage(int rollResult)
    {
		numberImage.enabled = true;
		numberImage.sprite = diceNumbers[rollResult];
	}

	public void SetItens(Item item, int index)
	{
		inventoryItens[index].text = item.collectMessage;
		infoText.text = item.collectMessage;
		StartCoroutine(FadingText());
	}

	public void SetClothes(int type)
    {
		ClearOldStuff(0);

		if (type == 0)
        {
			umbrella.SetActive(true);
			hat.SetActive(false);
		}
        else if (type==1)
        {
			umbrella.SetActive(false);
			hat.SetActive(false);
		}
        else
        {
			umbrella.SetActive(false);
			hat.SetActive(true);
        }
    }

	public void SetGifts(int type)
    {
		ClearOldStuff(1);
		if (type == 0)
		{
			apple.SetActive(true);
		}
		else if (type == 1)
		{
			candy.SetActive(true);
		}
		else if (type == 2)
		{
			controller.SetActive(true);
		}
		else if (type == 3)
        {
			gem.SetActive(true);
		}
		else if (type == 4)
		{
			moon.SetActive(true);
		}
		else if (type == 5)
		{
			car.SetActive(true);
		}
	}

	public void ClearOldStuff(int genre)
    {
        if (genre == 0)
        {
			// weather
			umbrella.SetActive(false);
			hat.SetActive(false);
        }
        else
        {
			moon.SetActive(false);
			apple.SetActive(false);
			car.SetActive(false);
			gem.SetActive(false);
			candy.SetActive(false);
			controller.SetActive(false);
        }
    }

	IEnumerator FadingText()
	{
		Color newColor = infoText.color;
		while (newColor.a < 1)
		{
			newColor.a += Time.deltaTime;
			infoText.color = newColor;
			yield return null;
		}

		yield return new WaitForSeconds(2f);

		while (newColor.a > 0)
		{
			newColor.a -= Time.deltaTime;
			infoText.color = newColor;
			yield return null;
		}
	}
}
