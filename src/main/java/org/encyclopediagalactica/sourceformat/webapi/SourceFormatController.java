package org.encyclopediagalactica.sourceformat.webapi;

import org.encyclopediagalactica.sourceformat.webapi.model.SourceFormatEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class SourceFormatController {
  
  @GetMapping("/get")
  public SourceFormatEntity get() {
    SourceFormatEntity sourceFormatEntity = new SourceFormatEntity();
    sourceFormatEntity.setId(10L);
    return sourceFormatEntity;
  }
  
}
