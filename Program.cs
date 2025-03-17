using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;

namespace PJT250317
{
    internal class Program
    {
        class GameObject
        {
            public GameObject(int inGold = 100, int inHP = 100, int inMP = 100)
            {
                Gold = inGold;
                MP = inMP;
                HP = inHP;
            }

            public int Gold;
            public int MP;
            public int HP;
        }
        static void Main(string[] args)
        {
            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(new GameObject(1, 2, 3));
            gameObjects.Add(new GameObject(4, 5, 6));
            gameObjects.Add(new GameObject(7, 8, 9));
            gameObjects.Add(new GameObject(10, 11, 12));

            string jsonData = JsonConvert.SerializeObject(gameObjects); // 객체를 Json 데이터로 변환

            Console.WriteLine(jsonData);

            List<GameObject> g2 = JsonConvert.DeserializeObject<List<GameObject>>(jsonData); // Json 데이터를 객체로 변환

            foreach(var go in g2)
            {
                Console.WriteLine(go.Gold);
            }
        }
    }
}
