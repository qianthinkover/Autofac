﻿// This software is part of the Autofac IoC container
// Copyright (c) 2007 - 2008 Autofac Contributors
// http://autofac.org
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;

namespace Autofac.Registrars
{
    /// <summary>
    /// Provides builder syntax for generic registrations.
    /// </summary>
    public interface IGenericRegistrar : IRegistrar<IGenericRegistrar>
    {
        /// <summary>
        /// Enforce that the specific constructor with the provided signature is used.
        /// </summary>
        /// <param name="ctorSignature">The types that designate the constructor to use.</param>
        /// <returns>A registrar allowing registration to continue.</returns>
        IGenericRegistrar UsingConstructor(params Type[] ctorSignature);

        /// <summary>
        /// Associates constructor parameters with default values.
        /// </summary>
        /// <param name="additionalCtorArgs">The named values to apply to the constructor.
        /// These may be overriden by supplying any/all values to the IContext.Resolve() method.</param>
        /// <returns>
        /// A registrar allowing registration to continue.
        /// </returns>
        IGenericRegistrar WithArguments(params Parameter[] additionalCtorArgs);

        /// <summary>
        /// Associates constructor parameters with default values.
        /// </summary>
        /// <param name="additionalCtorArgs">The named values to apply to the constructor.
        /// These may be overriden by supplying any/all values to the IContext.Resolve() method.</param>
        /// <returns>
        /// A registrar allowing registration to continue.
        /// </returns>
        IGenericRegistrar WithArguments(IEnumerable<Parameter> additionalCtorArgs);

        /// <summary>
        /// Provide explicit property values to be set on the new object.
        /// </summary>
        /// <param name="explicitProperties"></param>
        /// <returns>A registrar allowing configuration to continue.</returns>
        /// <remarks>Note, supplying a null value will not prevent property injection if
        /// property injection is done through an OnActivating handler.</remarks>
        IGenericRegistrar WithProperties(params NamedPropertyParameter[] explicitProperties);

        /// <summary>
        /// Provide explicit property values to be set on the new object.
        /// </summary>
        /// <param name="explicitProperties"></param>
        /// <returns>A registrar allowing configuration to continue.</returns>
        /// <remarks>Note, supplying a null value will not prevent property injection if
        /// property injection is done through an OnActivating handler.</remarks>
        IGenericRegistrar WithProperties(IEnumerable<NamedPropertyParameter> explicitProperties);
    }
}
