using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        int strength = Random.Range(0,11);
        int agility = Random.Range(0, 11);
        int intelligence = Random.Range(0, 11);

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log("Strength = " + strength + " Agility = "
            + agility + " Intelligence = " + intelligence);

        // let's create some float temporary variables to hold our multiplier values.

        // create an agility multiplier should be set to 0.5
        float agilityMultiplier = agility * 0.5f;

        // create a strength multiplier should be set to 1
        float strengthMultiplier = strength * 1f;

        // create an intelligence multiplier should be set to 2.
        float intelligenceMultiplier = intelligence * 2f;

        // Debug out our current multiplier values.
        Debug.Log("Agility = " + agilityMultiplier + " strength = " 
        + strengthMultiplier + " intelligence = " + intelligenceMultiplier);

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        float style = strengthMultiplier * 1f;

        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        float luck = intelligenceMultiplier * 1.5f;

        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        float rhythm = agilityMultiplier * 0.5f;

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log("Style = " + style + " luck = " + luck + " rhythm = " + rhythm);
        
        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10/3;
        float currentStrength = strengthMultiplier + additionalPoints;
        float currentAgility = agilityMultiplier + additionalPoints;
        float currentIntelligence = intelligenceMultiplier + additionalPoints;


        // Debug out our new physical stat values
        Debug.Log("Strength = " + currentStrength + " Agility = "
        + currentAgility + " Intelligence = " + currentIntelligence);

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        float currentStyle = currentStrength * 1f;
        float currentLuck = currentIntelligence * 1.5f;
        float currentRhythm = currentAgility * 0.5f;

        // Debug out our new dancing stat values
        Debug.Log("Style = " + currentStyle + " Luck = " + currentLuck + " Rhythm = " + currentRhythm);
    }
}
