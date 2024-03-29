﻿using System.Collections.Generic;

namespace Shutta
{
    public class Player
    {
        public Player(int money)
        {
            Money = money;

            _cards = new List<Card>();
        }

        public int Money { get; set; }

        protected readonly List<Card> _cards;

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public virtual void CalculateScore()
        {
            if (_cards[0].No == _cards[1].No)
                Score = _cards[0].No * 10; // 10 ~ 100
            else
                Score = (_cards[0].No + _cards[1].No) % 10; // 0 ~ 9
        }

        public int Score { get; set; }
        public int AmhaengoesaScore { get; set; }

        // indexer
        public Card this[int index]
        {
            get
            {
                return _cards[index];
            }
        }

        public void PrepareRound()
        {
            _cards.Clear();
            Score = 0;
            AmhaengoesaScore = 0;
        }
    }
}
