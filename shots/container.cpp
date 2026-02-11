#include <stdio.h>
#include <stdbool.h>

// This was made a few weeks ago, just putting this here.

int main(void) {
    // DECLARATION
    bool VAL_MET = false;
    int TEMP_VAL = 0;
    int VAL_CONTAINER = 0;
    int VAL_REACH = 3;
    int VAL_CONTAINER_COUNT = 10;

    // INTERAL PROCESS
    while (!VAL_MET) {
        bool IS_NEGATIVE = false; 
        // should at any point a negative happen we will absolute it, but incrementing it to 0, and then reaching the positive of that.
        TEMP_VAL++;

        if (TEMP_VAL == VAL_REACH) {
            VAL_CONTAINER += 1;
            TEMP_VAL = 0;
        }

        // STOP CONDITION
        if (VAL_CONTAINER == VAL_CONTAINER_COUNT) {
            VAL_MET = true;
        }
    }
    
    // COMPUTE THE PROCESS
    int SUMMATION = VAL_REACH * VAL_CONTAINER_COUNT;
    
    // OUTPUT THE COMPUTATION
    printf("VAL_CONTAINER = %d\n", VAL_CONTAINER);
    printf("CONTAINER SUMMATION = %d\n", SUMMATION);
    
    // END
    // NOTE: IT CAN BE greater than 0 if its a decrementing process to compute, in this case that will be repeated subtraction. or allowing negatives so all real numbers.
    return 0;
}
