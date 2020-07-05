# Corporate Deck Building Card Game

## A Game Project by

Jeremy Legere
Will Bartlett

## Project Proposal

### Title of the Game

The title of the game is undecided. The picture on the title page needs to be replaced.

### Authors and Contact Information

Jeremy Legere        |    jeremy.legere@unb.ca        |    5066092430
Will Bartlett        |    willm.bartlett@unb.ca       |    5069771407

### Game Description

The game pits two players against each other, where the players play corporations which are corporations in the same competitive space.

### Game Genre

The game is a competitive deck-building strategy game. It has an emphasis on any randomness in the game affecting both players equally (no randomness should give any player an explicit advantage), and an emphasis on having all decisions that are made throughout the game be meaningful to the outcome of a match. If a decision is not meaningful, it should be handled by the game engine.

### Main Game Rules and Concepts

#### Corporation

1. A corporation signifies a style of play that a player may use.
2. It determines the passive ability that a player has over the course of the game,
3. It determines the cards available for the base 10-card Base Deck that the player must construct before play.

#### Zones

1. A zone is a place which can house project cards, or be targetable by projects.
2. Common between all players, these zones are unique:
    The Market;
    The Stack (The deck of projects that source the Market);
3. A player owns several zones, each player has:
    Their Deck;
    Their Play Area, which consists of:
    Their External Row;
    Their Internal Row;
    Their Discard;
    Their Hand;
    Their Corporation (For projects that affect a player directly);

#### Deck Construction

1. Players must construct a 10-card deck before they can play a match.
2. All cards must be unique in the 10-card deck, except for the “Preliminary Research” card which produces +1 Research, of which there is no limit to how many copies are included in the base deck.
3. By default, the base deck includes 10 Preliminary Research Cards.

#### The Market

1. At the beginning of every round, there are 10 cards in the Market.
2. The five (5) least expensive projects of the market are called the Current Market and are available to research.
3. The five (5) most expensive projects of the market are called the Future Market and are unavailable to research.
4. The purpose of the Future Market is to decrease the randomness of drawing projects into the market from the stack, as players can see which projects will be potentially available in the future.
5. At the start of every round before the Main Phase, projects are drawn into the market until it is replenished to 10 cards. The cards are then sorted by Research cost.
6. During the Research Phase if a project in the Current Market is Researched, projects in the Future Market DO NOT enter the current market to bring the Current Market up to 5 projects.
7. If the Research Phase ends, and there are ten (10) projects left in the Market (no projects were researched), a Market Shift occurs, which drastically changes the projects available in the Market. (TBD how this happens. Maybe re-shuffle the Current and/or Future Market, and draw 5/10 new projects?)

#### Match

1. A match consists of two players, who play rounds.
2. When you have lost all available shares in your corporation, are no longer the majority shareholder of your corporation and you lose the game.
3. The last player in the game who has not lost is the winner of the match.

#### Round

1. At the beginning of every round, players draw five (5) project cards to their hand.
2. A round consists of one Main phase and an End-of-Round sequence.
3. After both players pass their turns for the research phase, the round is over and the “End-of-Round” is triggered.

#### Main Phase

1. The Main phase consists of:
    Turns alternating between players, until both players pass their turns for the remainder of the phase. 
    Passing can occur any time during the round on a player’s turn in the main phase. 
    If a player cannot fund a project or research a project on their turn, they are forced to pass.
2. End-of-Round consists of:
    The difference in total revenue from the players is used to buy that much stock from the player with less revenue.
    If any player has no stock left, they lose the game.
    Any project cards that are in the play area are moved to the discard, and any discarded project cards are shuffled together, and placed on the bottom of the owner’s deck.

#### Turn

1. On a player’s Turn dring the Main phase they must either:
    Play a card, or;
    Research a card, or;
    Pass, forgoing their turns for the rest of the Main phase.

#### Deck

1. Each player starts with a 10-Card Base Deck that is then modified throughout the match.
2. Discard
3. If a card would be discarded, it is instead placed on the bottom of the player’s deck.
Hand
4. The maximum hand size is 10. 
5. Any cards that are not played at the end of the round remain in the player’s hand.

#### External and Internal Rows

1. Each card will only execute its text if it is played in its indicated row.

### Gameplay

#### Pre-Match

The players choose a Corporation and construct a 10-card Base Deck before the match, and then the match is played. The objective of the game is to purchase enough stock in your opponents company to become the majority stakeholder and eliminate the opponent from the game.

#### Playing a Match

1. Both players start with a constructed 10-card Base Deck, and modify their deck over the course of the Match. Which project cards you acquire from the Market, and which project cards your opponent acquires is one of the key factors to the outcome of the game. 

2. The game is played in rounds, in which players take turns playing a single project card until both players choose to pass their turns for the rest of the round. A player is forced to pass if they cannot play a card.
A project may be played in one of two zones of the play area - the Internal Row, or the External Row. Each project has separate text for each zone.

### Game Universe
1. Sci-Fi so we can have futuristic cards, and exaggerated/cynical corporate processes? Business leaders regarded as cult leaders?
2. Unregulated capitalism, and exploitation of workers?
3. https://www.youtube.com/watch?v=rp0M5Y6JMbQ
4. Orwellian vibes
5. Morally questionable projects

### Planned Game Engine

For the project, we will be using Unity version 2019.4.0f1 LTS with C# as the scripting language. 

### Planned Game Platform and Operating Systems

We are targeting the PC platform for this project. This includes builds for Windows, and Mac. Maybe also a physical card game?

### Visual Design

Listing specific games visual design as inspiration
