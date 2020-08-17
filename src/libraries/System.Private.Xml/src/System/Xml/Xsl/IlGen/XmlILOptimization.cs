// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable
namespace System.Xml.Xsl.IlGen
{
    /// <summary>
    /// Xml IL patterns.
    /// </summary>
    internal enum XmlILOptimization
    {
        None,
        EliminateLiteralVariables,
        TailCall,

        // Do not edit this region
        // It is auto-generated
        #region AUTOGENERATED
        AnnotateAncestor,
        AnnotateAncestorSelf,
        AnnotateAttribute,
        AnnotateAttrNmspLoop,
        AnnotateBarrier,
        AnnotateConstruction,
        AnnotateContent,
        AnnotateContentLoop,
        AnnotateDescendant,
        AnnotateDescendantLoop,
        AnnotateDescendantSelf,
        AnnotateDifference,
        AnnotateDod,
        AnnotateDodMerge,
        AnnotateDodReverse,
        AnnotateFilter,
        AnnotateFilterAttributeKind,
        AnnotateFilterContentKind,
        AnnotateFilterElements,
        AnnotateFollowingSibling,
        AnnotateIndex1,
        AnnotateIndex2,
        AnnotateIntersect,
        AnnotateInvoke,
        AnnotateJoinAndDod,
        AnnotateLet,
        AnnotateMaxLengthEq,
        AnnotateMaxLengthGe,
        AnnotateMaxLengthGt,
        AnnotateMaxLengthLe,
        AnnotateMaxLengthLt,
        AnnotateMaxLengthNe,
        AnnotateMaxPositionEq,
        AnnotateMaxPositionLe,
        AnnotateMaxPositionLt,
        AnnotateNamespace,
        AnnotateNodeRange,
        AnnotateParent,
        AnnotatePositionalIterator,
        AnnotatePreceding,
        AnnotatePrecedingSibling,
        AnnotateRoot,
        AnnotateRootLoop,
        AnnotateSingleTextRtf,
        AnnotateSingletonLoop,
        AnnotateTrackCallers,
        AnnotateUnion,
        AnnotateUnionContent,
        AnnotateXPathFollowing,
        AnnotateXPathPreceding,
        CommuteDodFilter,
        CommuteFilterLoop,
        EliminateAdd,
        EliminateAfter,
        EliminateAnd,
        EliminateAverage,
        EliminateBefore,
        EliminateConditional,
        EliminateDifference,
        EliminateDivide,
        EliminateDod,
        EliminateEq,
        EliminateFilter,
        EliminateGe,
        EliminateGt,
        EliminateIntersection,
        EliminateIs,
        EliminateIsEmpty,
        EliminateIsType,
        EliminateIterator,
        EliminateIteratorUsedAtMostOnce,
        EliminateLe,
        EliminateLength,
        EliminateLoop,
        EliminateLt,
        EliminateMaximum,
        EliminateMinimum,
        EliminateModulo,
        EliminateMultiply,
        EliminateNamespaceDecl,
        EliminateNe,
        EliminateNegate,
        EliminateNop,
        EliminateNot,
        EliminateOr,
        EliminatePositionOf,
        EliminateReturnDod,
        EliminateSequence,
        EliminateSort,
        EliminateStrConcat,
        EliminateStrConcatSingle,
        EliminateStrLength,
        EliminateSubtract,
        EliminateSum,
        EliminateTypeAssert,
        EliminateTypeAssertOptional,
        EliminateUnion,
        EliminateUnusedGlobals,
        EliminateXsltConvert,
        FoldConditionalNot,
        FoldNamedDescendants,
        FoldNone,
        FoldXsltConvertLiteral,
        IntroduceDod,
        IntroducePrecedingDod,
        NormalizeAddEq,
        NormalizeAddLiteral,
        NormalizeAttribute,
        NormalizeConditionalText,
        NormalizeDifference,
        NormalizeEqLiteral,
        NormalizeGeLiteral,
        NormalizeGtLiteral,
        NormalizeIdEq,
        NormalizeIdNe,
        NormalizeIntersect,
        NormalizeInvokeEmpty,
        NormalizeLeLiteral,
        NormalizeLengthGt,
        NormalizeLengthNe,
        NormalizeLoopConditional,
        NormalizeLoopInvariant,
        NormalizeLoopLoop,
        NormalizeLoopText,
        NormalizeLtLiteral,
        NormalizeMuenchian,
        NormalizeMultiplyLiteral,
        NormalizeNeLiteral,
        NormalizeNestedSequences,
        NormalizeSingletonLet,
        NormalizeSortXsltConvert,
        NormalizeUnion,
        NormalizeXsltConvertEq,
        NormalizeXsltConvertGe,
        NormalizeXsltConvertGt,
        NormalizeXsltConvertLe,
        NormalizeXsltConvertLt,
        NormalizeXsltConvertNe,
        #endregion // AUTOGENERATED

        // Must appear last in the enum
        Last_,
    }
}
