﻿using System;

namespace TinyMapper.DataStructures
{
    internal struct TypePair : IEquatable<TypePair>
    {
        public TypePair(Type source, Type target) : this()
        {
            Target = target;
            Source = source;
        }

        public Type Source { get; private set; }
        public Type Target { get; private set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is TypePair && Equals((TypePair)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Source != null ? Source.GetHashCode() : 0) * 397) ^ (Target != null ? Target.GetHashCode() : 0);
            }
        }

        public bool Equals(TypePair other)
        {
            return Source == other.Source && Target == other.Target;
        }
    }
}