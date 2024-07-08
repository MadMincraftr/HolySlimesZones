using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace HolySlimes.Behaviors
{
    public class CustomSpawner : MonoBehaviour
    {
        public string[] slimes;

        public void Start()
        {
            var ss = GetComponent<DirectedSlimeSpawner>();
            int i = 0;
            foreach (var ssm in ss.constraints[0].slimeset.members)
            {
                ssm.prefab = GameContext.Instance.LookupDirector.GetPrefab((Identifiable.Id)Enum.Parse(typeof(Identifiable.Id), slimes[i]));
                i++;
            }
        }
    }
}
