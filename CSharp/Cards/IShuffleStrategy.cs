namespace Cards;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public interface IShuffleStrategy {
    void Shuffle(List<Card> cards);
}