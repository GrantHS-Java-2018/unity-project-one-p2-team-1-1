using System;
using System.Collections;

namespace Prefabs
{
    public class CardCollection
    {
        private String label;
        private ArrayList<Card> cards;

        public CardCollection(String label)
        {
            this.label = label;
            this.cards = new ArrayList<Card>();
        }

        public void addCard(Card card)
        {
            this.cards.Add(card);
        }

        public void addCard(Card card)
        {
            this.cards.Add(card);
        }

        public Card popCard(int i)
        {
            return cards.Remove(i);
        }
        
        public int size() {
            return cards.size();
        }
        
        public boolean empty() {
            return cards.size() == 0;
        }
        
        public void deal(CardCollection that, int n) {
            for (int i = 0; i < n; i++) {
                Card card = popCard();
                that.addCard(card);
            }
        }
        
        public Card getCard(int i) {
            return cards.get(i);
        }
        
        public Card last() {
            int i = size() - 1;
            return cards.get(i);
        }
        
        public void swapCards(int i, int j) {
            Card temp = cards.get(i);
            cards.set(i, cards.get(j));
            cards.set(j, temp);
        }
        
        public void shuffle() {
            Random random = new Random();
            for (int i = size() - 1; i > 0; i--) {
                int j = random.nextInt(i);
                swapCards(i, j);
            }
        }
    }
}