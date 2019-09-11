# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Added
- Add PointWrapper AHK class to make dealing with List<Point> easy
### Changed
- Replaced getX() / getY() methods for Point class with .X and .Y properties
- Switch from using `Point[]` to `List<Point>`
### Deprecated
### Removed
- Remove commented code, superfluous Console.Write statements
### Fixed

## [0.0.1] - 2019-09-11
### Changed
- Changed GrahamScan function to return Point array instead of outputting to console
- Demo program now parses Point array and outputs results
### Added
- Added AHK interop
- Added PointsList class to build List<Point> from AHK
