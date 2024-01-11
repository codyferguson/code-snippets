package com.codyferguson;

public class CustomStack {
    private static final int STANDARD_SIZE = 10;

    private int[] stackArray;
    private int size;
    private int top;

    public CustomStack() {
        size = STANDARD_SIZE;
        stackArray = new int[size];
        top = 0;
    }

    public CustomStack(int size) {
        this.size = size;
        stackArray = new int[size];
        top = 0;
    }

    public int pop() {
        return -1;
    }

    public void push(int element) {

    }

    public
}
