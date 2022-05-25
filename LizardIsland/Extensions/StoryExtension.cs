namespace LizardIsland.Extensions
{
    public class StoryExtension
    {
        public static void Intro()
        {
            //TITLE SCREEN
            Console.WriteLine("==========================");
            Console.WriteLine("      LIZARD ISLAND       ");
            Console.WriteLine("==========================");
            Console.WriteLine("a text adventure by Hayden Kirsch Ball");
            Console.WriteLine("\n\nYou are startled awake as the nearby sound of thunder cracks through the sky like an axe splitting a boars skull.");
            Console.WriteLine("\nPress :enter: to begin.");
            Console.ReadKey();

            //INTRO SCENE ON BOAT
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine(" PRISONER QUARTERS, IMPERIAL NAVAL SHIP  ");
            Console.WriteLine("=========================================");
            Console.WriteLine("\nThrough your groggy vision you appear to be in the hull of a ship... though not one you are familar with.");
            Console.WriteLine("Your internal gyroscope is working overtime as you work to get your bearings out on the violence of the open sea.");
            Console.ReadKey();
            Console.WriteLine("\nYour hands are cuffed... a prisoner?");
            Console.WriteLine("One of many it would seem.");
            Console.ReadKey();
            Console.WriteLine("\n'Good to see you come-to eh?? Worried those bastard empire dogs beat ye' too good.'");
            Console.WriteLine("'They don't take kindly to us Pirates.'");
            Console.ReadKey();
            Console.WriteLine("\n'The name is Cronan.'");
            Console.ReadKey();
            Console.WriteLine("\nCronan was a portly man no taller than a mailbox. (No thinner than one either.)");
            Console.ReadKey();
            Console.WriteLine("\nTo his left was a tall knobby man who was missing a shoe.");
            Console.WriteLine("A rat was gnawing his big toe to a bloody stump. ");
            Console.WriteLine("It didn't seem to bother the lanky man though - in fact he didn't even seem to notice.");
            Console.ReadKey();
            Console.WriteLine("\nTo Cronans right was an old man with a long silver beard.");
            Console.ReadKey();
            Console.WriteLine("\n'This tall dumb bastard here is Painless Paulie... coconut fell on his spine when he was just a lad...'");
            Console.WriteLine("'hasn't been able t'feel a thing since.'");
            Console.ReadKey();
            Console.WriteLine("\n'And this old scoundrel here is Hayes...Sharp as a tack but don't ask him for advice.'");
            Console.WriteLine("'The stubborn geezer hasn't said a word since 1652.'");
            Console.ReadKey();
            Console.WriteLine("\n'Say, adventurer. What do we call ya?'");
        }
        public static void Shipwreck(string name)
        {
            //CHARACTER NAME
            if (name == "Hero")
            {
                Console.WriteLine("\n...I can't even remember my own name...? Who am I?");
                Console.ReadKey();
                Console.WriteLine("\nCronan seems annoyed." +
                    "\n'Alright then adventurer...keep it to yerself then.'");
                Console.ReadKey();
                Console.WriteLine("Old man Hayes and Painless Paulie snicker");

            }
            else
                Console.WriteLine("\nWell...  " + name + " ain't that an ugly name?" +
                    "\nOld man Hayes and Painless Paulie snicker");
            Console.ReadKey();

            //SHIPWRECK
            Console.WriteLine("\nCRASH!!!");
            Console.ReadKey();
            Console.WriteLine("\nAll of a sudden you are thrown into the air. You hear the splintering of wood and water rushing into the hull.");
            Console.WriteLine("You slam your head on something hard and your vision fades to black...");
            Console.ReadKey();
            Console.WriteLine("\nAs your vision fades you can still hear that rat gnawing on Paulies toe...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Beach()
        {
            //BEACH
            Console.WriteLine("===============================");
            Console.WriteLine(" BEACH, SOUTHERN LIZARD ISLAND");
            Console.WriteLine("===============================");
            Console.WriteLine("Your eyes open only to be nearly blinded by the hot sun reflecting off the white sand. You have washed up on a beach.");
            Console.ReadKey();
            Console.WriteLine("\nBehind you is the wreckage of the Imperial Naval Ship that once held you captive.");
            Console.ReadKey();
            Console.WriteLine("\nIn front of you the small private beach leads to a trail into the jungle...you look up just in time to see a short fat man, a tall lanky man and a strong old man running into the forest.");
            Console.ReadKey();
            Console.WriteLine("\nIt seems as though Cronan, Painless Paulie and Old Man Hayes survived the shipwreck as well.");
            Console.ReadKey();
            Console.WriteLine("\nYou lift your head off the hot sand and sit up to take in your surroundings.");
            Console.ReadKey();
            Console.WriteLine("\nThere are pools of blood surrounding the corpses of both pirate prisoners and Imperial Sailors floating in the shallow waters.");
            Console.WriteLine("'Gotta be careful of sharks', you think.");
            Console.ReadKey();
            Console.WriteLine("\n   ");
            Console.WriteLine("Floating in the shallow waters on the far end of the ship you find both a Rusty (S)abre and a (B)uckler. You equip them both.");
            Console.ReadKey();
            Console.WriteLine("\nYou then search the satchel of a pirate with a wooden splinter rammed through his eye socket and find (Qty. 5) (P)otions.");
            Console.WriteLine("'These must be able to heal me in battle' - you think to yourself.");
            Console.ReadKey();
            Console.WriteLine("\nJust as you wade back onto the beach and set off towards the jungle trail you hear a voice behind you");
            Console.WriteLine("'Pirate scum! Where do you think you're going? You are under arrest for charges of piracy by the Imperial Navy!'");
            Console.ReadKey();
            Console.WriteLine("\nYou didn't care too much for being imprisoned the last time and besides...you notice the Imperial Sailor is limping.");
            Console.ReadKey();
            Console.WriteLine("\nYou ready your sword for battle");
        }

        public static void EndBeach(int money)
        {
            //END OF BEACH
            Console.Clear();
            Console.WriteLine("You stand over the dead Imperial Sailor and use his shirt to wipe the blood off your sabre.");
            Console.ReadKey();
            Console.WriteLine("\nYou search his pockets and find " + money + " Lizard Tails.");
            Console.ReadKey();
            Console.WriteLine("\n'These must be used as currency on this Island' you think to yourself...'that means there must be a town nearby!'");
            Console.ReadKey();
            Console.WriteLine("\nHope has quickened your pace, and you walk off the beach into the jungle trail heading north.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void JungleIntro()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("     JUNGLE, LIZARD ISLAND     ");
            Console.WriteLine("===============================");
            Console.ReadKey();
            Console.WriteLine("\nAs you enter the jungle the temperature cools dramatically.");
            Console.WriteLine("The jungle buzzes with life all around you as you traverse the beaten path.");
            Console.ReadKey();
            Console.WriteLine("\nThe lush foliage fills your senses with fresh smelling greenery, and sweet smelling flowers.");
            Console.WriteLine("You take a moment to appreciate the beauty of nature as a free man.");
            Console.ReadKey();
            Console.WriteLine("\nNot even two moons ago you were a prisoner chained up in a foul smelling ship.");
            Console.ReadKey();
            Console.WriteLine("\nYour nice moment of zen is interrupted as your stomach rumbles you back to reality. You are hungry and alone. Exposed in an unfamiliar area.");
            Console.ReadKey();
            Console.WriteLine("\nYou need to find shelter soon. 'This path must lead to some kind of town....' you think to yourself.");
            Console.ReadKey();
            Console.WriteLine("\nYour pace quickens and you follow the trail deeper into the jungle.");
            Console.ReadKey();
            Console.WriteLine("\nThe trail winds to the right...");
            Console.ReadKey();
            Console.WriteLine("\nAnd zigs back left...");
            Console.ReadKey();
            Console.WriteLine("\nZags right...");
            Console.ReadKey();
            Console.WriteLine("\nThen the path leads you towards a sharp left turn when you are SUDDENLY JUMPED by TWO NASTY MONSTERS!");
            Console.ReadKey();
            Console.WriteLine("\nGet ready to fight!");
            Console.ReadKey();
        }

        public static void JungleMain()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("     JUNGLE, LIZARD ISLAND     ");
            Console.WriteLine("===============================");
            Console.ReadKey();
            Console.WriteLine("\nYou stand over your two victims and wipe the blood from your sabre.");
            Console.ReadKey();
            Console.WriteLine("\nIt appears as if these jungles are more dangerous than originally thought...");
            Console.ReadKey();
            Console.WriteLine("\nNo time to linger and reflect on the dead. Time to carry on.");
            Console.ReadKey();
            Console.WriteLine("\nYou continue along the path on high alert...");
            Console.ReadKey();
            Console.WriteLine(".");
            Console.ReadKey();
            Console.WriteLine("..");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("Hours pass...");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("..");
            Console.ReadKey();
            Console.WriteLine(".");
            Console.ReadKey();
            Console.WriteLine("Just as one might begin to entertain thoughts of doubt, smoke enters your bruised nostrils. You smell a campfire.");
            Console.WriteLine("Your dry nostrils sting as the smoke fills them. In pain, you instinctively wipe your nose. You realize its covered in dry blood.");
            Console.ReadKey();
            Console.WriteLine("\nThe path before you leads to a clearing in the dense jungle, a circular grassy area.");
            Console.WriteLine("In the middle of the clearing remains the glow of waning fire. Someone had been here recently.");
            Console.ReadKey();
            Console.WriteLine("\nOn one end of the clearing was a wrecked caravan, its wooden walls were cracked and its canvas top torn.");
            Console.WriteLine("Someone had been attacked and looted recently?");
            Console.ReadKey();
            Console.WriteLine("\n CRACK!!");
            Console.ReadKey();
            Console.WriteLine("\nLike a gunshot in the night, you hear the unmistakable sound of a twig snapping in the woods.");
            Console.WriteLine("The sound came from the woods opposite of the broken caravan. You were not alone.");
            Console.ReadKey();
            Console.WriteLine("\nYou call out to the woods... 'SHOW YOURSELF!.'");
            Console.WriteLine("...the woods do not respond.");
            Console.ReadKey();
            Console.WriteLine("\nWhomever was nearby must have run away...");
            Console.WriteLine("The wreckage of this encampment was not done by one man, and a group of men would certainly see you as an empty target.");
            Console.WriteLine("Perhaps it was a victim of the attack... scared I was another opportunist looking for loot.");
            Console.ReadKey();
            Console.WriteLine("\nRegardless... you are alone now.");
            Console.ReadKey();
            Console.WriteLine("\nYou rip the rest of the cotton canvas off the roof of the tattered caravan. You figure it will come in handy as a blanket.");
            Console.ReadKey();
            Console.WriteLine("\nYou walk 5 minutes off the trail into the woods so as to not be discovered easily in the night... You lay your head down and sleep.");
        }
    }
}
