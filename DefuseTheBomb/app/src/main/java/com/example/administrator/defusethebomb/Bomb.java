package com.example.administrator.defusethebomb;


import android.os.Parcel;
import android.os.Parcelable;
import android.util.Log;

import java.io.Serializable;

public class Bomb implements Serializable {

    // win flag
    private Boolean gameOver;
    // target "wire"
    private int target;
    // score holder
    int score;
    long remainingTime;
    boolean active;

    // constructor method
    public Bomb() {
        reset();
    }

    //-----------------------------------------------------get/set methods
    public boolean getGameOver() {
        return gameOver;
    }

    public int getScore() {
        return score;
    }

    public void setScore(int s) {
        score = s;
    }

    public long getRemainingTime() {
        return remainingTime;
    }

    public void setRemainingTime(long t) {
        remainingTime = t;
    }

    public boolean getGameState() {
        return active;
    }

    public void setGameState(boolean a) {
        active = a;
    }

    //-----------------------------------------------------public methods
    public void reset() {
        // // TODO: 12/10/2015 set wires back to random after testing
        gameOver = false;

        // determine target wire
        target = (int) (Math.random() * 3);


    }

    public boolean selected(int click) {
        // boolean flag for whether the user's click matches the target or notTargets
        /*gameOver = false;


        if (click == target) {
            gameOver = true;
        }

        // check to see if the wire selected by user is equal to the right wire
        if (flag) {
            gameOver = true;
        } else {
*/

        if (click == target) {
            return gameOver = true;
        } else {
            return gameOver = false;
        }
    }


}
