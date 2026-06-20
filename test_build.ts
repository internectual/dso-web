// test_build.ts - Quick test
import { Compiler } from './src/compiler/index';
import { decompile } from './src/decompiler';
import * as fs from 'fs';

const targets = ['TGE10','Tribes2','TGE14','Constructor','TFD','BlocklandV1','BlocklandV20','BlocklandV21'];
for (const target of targets) {
  const c = new Compiler(target);
  const b = c.compile('function test() { return 1; }');
  const r = decompile(new Uint8Array(b));
  console.log(`${target}: ${r.ok ? 'PASS' : 'FAIL: ' + r.error.split('\n')[0]}`);
}

const r2 = decompile(fs.readFileSync('/home/methodown/Downloads/GameGui.cs.dso'));
console.log(`Real DSO: ${r2.ok ? 'PASS (' + r2.source.length + ' chars)' : 'FAIL'}`);
