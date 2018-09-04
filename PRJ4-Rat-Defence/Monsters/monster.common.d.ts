/**
 * The variables to be set for a monster upon creation
 */
export interface MonsterTemplate {
    /**
     * The name of the monster created
     */
    name: string;
    /**
     * The amount of health a monster has
     */

    health: number;

    /**
    * The speed at which a monster moves 
    */
    speed: number;

    /**
     * A restistance to a certain elemental type of damage
     */

    resistance: {
        frost: boolean;
        fire: boolean;
        earth: boolean;
        water: boolean;
    }

    /**
     * Whether the monster is alive or not. Is set to false when dead or reached endzone.
     */
    
    alive: boolean;
}
