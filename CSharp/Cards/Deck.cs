namespace Cards;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class Deck {
    private List<Card> _cards;
    private readonly IShuffleStrategy _shuffleStrategy;

    public Deck(IShuffleStrategy shuffleStrategy) {
        _shuffleStrategy = shuffleStrategy;
        Reset();
    }

    public void Shuffle() => _shuffleStrategy.Shuffle(_cards);

    public void Reset()
    {
        _cards = new List<Card>();
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] ranks = { "Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King" };

        foreach (var suit in suits)
            foreach (var rank in ranks)
                _cards.Add(new Card(suit, rank));
    }

    public Card Deal()
    {
        if (_cards == null || _cards.Count == 0)
            throw new InvalidOperationException("Deck is empty. Reset before dealing.");

        var card = _cards[0];   // take the top card
        _cards.RemoveAt(0);     // remove it from deck
        return card;
    }

    public IReadOnlyList<Card> GetCards() => _cards.AsReadOnly();
}
