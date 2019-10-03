﻿// Copyright (c) 2019 Andreas Atteneder, All Rights Reserved.

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using UnityEngine.Experimental.Rendering;
using KtxUnity;

public class BasisUniversalTestTexture : BasisUniversalTexture
{
    public GraphicsFormat graphicsFormat;
    public TextureFormat? textureFormat;
    public TranscodeFormat transF;

    protected override bool GetFormat(
        IMetaData meta,
        ILevelInfo li,
        out GraphicsFormat graphicsFormat,
        out TextureFormat? textureFormat,
        out TranscodeFormat transF
    ) {

        graphicsFormat = GraphicsFormat.None;
        textureFormat = null;
        transF = this.transF;

        if(this.textureFormat.HasValue) {
            textureFormat = this.textureFormat;
        } else {
            graphicsFormat = this.graphicsFormat;
        }

        return true;
    }
}
