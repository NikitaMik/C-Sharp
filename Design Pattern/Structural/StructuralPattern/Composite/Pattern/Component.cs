﻿using System;

namespace Composite
{
    abstract class Component
    {
        protected string name;

        public Component(String name)
        {
            this.name = name;
        }

        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int index);
    }
}
