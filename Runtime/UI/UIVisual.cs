// ------------------------------------------------------------------------------
//  File: UIVisual.cs
//  Author: Ran
//  Description: Base class for visual elements in the UI.
//  Created: 2025
//  
//  Copyright (c) 2025 Ran.
//  This script is part of the ran.utilities namespace.
//  Permission is granted to use, modify, and distribute this file freely
//  for both personal and commercial projects, provided that this notice
//  remains intact.
// ------------------------------------------------------------------------------

using UnityEngine;

namespace ran.utilities
{
    /// <summary>
    /// Base class for visual elements in the UI that are bound to data of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of data this visual element represents.</typeparam>
    public abstract class UIVisual<T> : MonoBehaviour
    {
        /// <summary>
        /// The data associated with this UI visual.
        /// </summary>
        [Tooltip("The data associated with this UI visual. " + "\n" +
                "If null, system will assume that data is updated automatically by the system.")]
        [SerializeField] private T data;

        /// <summary>
        /// Gets the data associated with this UI visual.
        /// </summary>
        public T Data => data;

        /// <summary>
        /// Indicates whether data is loaded.
        /// </summary>
        public virtual bool IsLoaded => data != null;

        /// <summary>
        /// Loads new data into this UI visual.
        /// </summary>
        /// <param name="newData">The new data to load.</param>
        public virtual void Load(T newData)
        {
            data = newData;
            Refresh();
        }

        /// <summary>
        /// Unloads the current data from this UI visual.
        /// </summary>
        public virtual void Unload()
        {
            data = default;
            Reset();
        }

        /// <summary>
        /// Refreshes the UI visual based on the current data.
        /// </summary>
        public abstract void Refresh();

        /// <summary>
        /// Resets the UI visual to its default state.
        /// </summary>
        public abstract void Reset();

        /// <summary>
        /// Shows the UI visual according to the implemented logic.
        /// Override this method to incorporate additional functionality.
        /// </summary>
        public virtual void Show() => gameObject.SetActive(true);

        /// <summary>
        /// Hides the UI visual according to the implemented logic.
        /// Override this method to incorporate additional functionality.
        /// </summary>
        public virtual void Hide() => gameObject.SetActive(false);
    }
}
