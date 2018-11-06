package com.anexsys.recruitment.challenge;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import org.junit.Test;

public class CardTest {

    @Test
    public void shouldImplementHashCodeAndEquals() {
        Card sut1 = new Card(Suit.CLUBS, Rank.ACE, "deck ID");
        Card sut2 = new Card(Suit.CLUBS, Rank.ACE, "deck ID");
        assertEquals(sut1.hashCode(), sut2.hashCode());
        assertTrue(sut1.equals(sut2));
        assertFalse(sut1.equals(null));
        assertFalse(sut1.equals(new Card(Suit.CLUBS, Rank.ACE, "different deck ID")));
    }

}
