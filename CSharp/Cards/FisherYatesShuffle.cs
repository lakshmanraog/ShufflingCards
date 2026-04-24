namespace Cards;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FisherYatesShuffle : IShuffleStrategy {
    private readonly Random _random = new Random();
    public void Shuffle(List<Card> cards) {
        for (int i = cards.Count - 1; i > 0; i--) {
            int j = _random.Next(i + 1);
            (cards[i], cards[j]) = (cards[j], cards[i]);
        }
    }
}