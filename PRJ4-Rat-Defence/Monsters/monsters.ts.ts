import { MonsterTemplate } from './monster.common'

export class Monsters {

    //this entire section is pseudo TypeScript and is only to show an example of the idea


    listOfMonsterTypes: {
        /**
         * RAT now has the template of a monster and we're able to set all the values.
         * How does is done can be argued - perhaps there's an easier way than to create a method and pack it.
         */
        RAT: MonsterTemplate;
        ...
        ....
        .....
    }

    createMonster(monster: MonsterTemplate, amount: number ){
        for(var i = 0; i = amount+1; i++){
            //create monster
        }
    }
}
    
//To create a monster (once setting the values has been figuredo out) one would only need
//to type createMonster(RAT, 10); inside the wave generation of the map to create monsters
//making this super scaleable. However adding monsters can be a slightly bit tedious.