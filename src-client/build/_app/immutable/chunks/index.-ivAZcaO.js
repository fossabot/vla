const r=[];function f(){}function h(t,n){return{subscribe:d(t,n).subscribe}}function p(t,n){return t!=t?n==n:t!==n||t&&typeof t=="object"||typeof t=="function"}function d(t,n=f){let i=null;const o=new Set;function u(s){if(p(t,s)&&(t=s,i)){const c=!r.length;for(const e of o)e[1](),r.push(e,t);if(c){for(let e=0;e<r.length;e+=2)r[e][0](r[e+1]);r.length=0}}}function b(s){u(s(t))}function l(s,c=f){const e=[s,c];return o.add(e),o.size===1&&(i=n(u,b)||f),s(t),()=>{o.delete(e),o.size===0&&i&&(i(),i=null)}}return{set:u,update:b,subscribe:l}}export{h as r,d as w};
