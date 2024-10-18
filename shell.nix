{ pkgs ? import <nixpkgs> { } }:
pkgs.mkShell {
  name = "dotnet";
  # Additional tooling
  buildInputs = with pkgs; [
    dotnet-sdk_8
  ];

  DOTNET_ROOT="${pkgs.dotnet-sdk_8}";
}
