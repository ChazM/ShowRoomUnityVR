using UnityEngine;
public class Misil : MonoBehaviour{
    public GameObject MisilObj;
    public enum misil { Brahmos, Paveway, StormShadow, Penquin}
    public misil misilType;
    public bool isVisible;
}