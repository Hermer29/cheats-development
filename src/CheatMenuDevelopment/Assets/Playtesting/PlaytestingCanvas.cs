using System;
using Hermer29.Cheats;
using Hermer29.Cheats.DebugValues;
using UnityEngine;
using UnityEngine.UI;

namespace Playtesting
{
    public class PlaytestingCanvas : MonoBehaviour, ICheatHandler
    {
        [SerializeField] private Button _createCheats;
        [SerializeField] private InputField _key;
        [SerializeField] private InputField _value;
        [SerializeField] private Button _submit;

        private void Start()
        {
            _createCheats.onClick.AddListener(OnCheatsCreateRequested);
            _submit.onClick.AddListener(OnKeyValueSubmit);
        }

        private void OnKeyValueSubmit()
        {
            Cockpit.SetReadOnly(_key.text, _value.text);
        }

        private void OnCheatsCreateRequested()
        {
            Cheats.Create(new ICheatHandler[] { this});
        }

        public string GetCheatCode()
        {
            return "myCheat";
        }

        public void Execute()
        {
            Debug.Log("My cheat called");
        }
    }
}