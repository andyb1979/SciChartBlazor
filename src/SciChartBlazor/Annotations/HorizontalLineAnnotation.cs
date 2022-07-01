﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciChartBlazor.Annotations;

public class HorizontalLineAnnotation : AnnotationBase
{
    [SciChartElementType]
    public override string Type => "RenderContextHorizontalLineAnnotation";
    public LabelPlacement? LabelPlacement { get; set; }
    public bool? ShowLabel { get; set; }
    public string? Stroke { get; set; }
    public double? StrokeThickness { get; set; }
    public string? AxisLabelFill { get; set; }
}

