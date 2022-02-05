﻿using UnityEngine;

public static class Extensions {
    public static void Clear(this Texture2D texture, Color color) {
        Color[] colors = new Color[texture.width * texture.height];
        for (int i = 0; i < colors.Length; i++) {
            colors[i] = color;
        }

        texture.SetPixels(0, 0, texture.width, texture.height, colors);
    }

    public static Vector2 Rotate(this Vector2 vector, float degrees) {
        return Quaternion.Euler(0, 0, degrees) * vector;
    }

    public static void Fill<T>(this T[] array, T value) {
        for (int i = 0; i < array.Length; i++) {
            array[i] = value;
        }
    }

    public static T GetCoordinate<T>(this T[] array, int x, int y, int width) {
        return array[x + y * width];
    }

    public static void SetCoordinate<T>(this T[] array, int x, int y, int width, T value) {
        array[x + y * width] = value;
    }

    public static uint ToUInt(this Color32 color) {
        return (uint)(color.a << 24 | color.r << 16 | color.g << 8 | color.b << 0);
    }

    public static Color32 ToColor(this uint colorUInt) {
        return new Color32((byte)(colorUInt >> 16), (byte)(colorUInt >> 8), (byte)(colorUInt >> 0), (byte)(colorUInt >> 24));
    }
}
