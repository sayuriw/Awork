using System;
using System.Collections.Generic;

using Awork.Data;

namespace Awork.Data
{
    public class CardService
    {
        private IList<CardData> cardList = new List<CardData>();

        public void createObjCard(CardData data)
        {
            cardList.Add(data);
        }

        //public List<CardData> GetCards()
        //{

        //    return cardList
        //}
    }
}
