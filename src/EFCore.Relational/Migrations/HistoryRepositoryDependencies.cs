// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.EntityFrameworkCore.Migrations
{
    /// <summary>
    ///     <para>
    ///         Service dependencies parameter class for <see cref="HistoryRepository" />
    ///     </para>
    ///     <para>
    ///         This type is typically used by database providers (and other extensions). It is generally
    ///         not used in application code.
    ///     </para>
    ///     <para>
    ///         Do not construct instances of this class directly from either provider or application code as the
    ///         constructor signature may change as new dependencies are added. Instead, use this type in
    ///         your constructor so that an instance will be created and injected automatically by the
    ///         dependency injection container. To create an instance with some dependent services replaced,
    ///         first resolve the object from the dependency injection container, then replace selected
    ///         services using the 'With...' methods. Do not call the constructor at any point in this process.
    ///     </para>
    ///     <para>
    ///         Do not construct instances of this class directly from either provider or application code as the
    ///         constructor signature may change as new dependencies are added. Instead, use this type in
    ///         your constructor so that an instance will be created and injected automatically by the
    ///         dependency injection container. To create an instance with some dependent services replaced,
    ///         first resolve the object from the dependency injection container, then replace selected
    ///         services using the 'With...' methods. Do not call the constructor at any point in this process.
    ///     </para>
    ///     <para>
    ///         The service lifetime is <see cref="ServiceLifetime.Scoped"/>. This means that each
    ///         <see cref="DbContext"/> instance will use its own instance of this service.
    ///         The implementation may depend on other services registered with any lifetime.
    ///         The implementation does not need to be thread-safe.
    ///     </para>
    /// </summary>
    public sealed class HistoryRepositoryDependencies
    {
        /// <summary>
        ///     <para>
        ///         Creates the service dependencies parameter object for a <see cref="HistoryRepository" />.
        ///     </para>
        ///     <para>
        ///         Do not call this constructor directly from either provider or application code as it may change
        ///         as new dependencies are added. Instead, use this type in your constructor so that an instance
        ///         will be created and injected automatically by the dependency injection container. To create
        ///         an instance with some dependent services replaced, first resolve the object from the dependency
        ///         injection container, then replace selected services using the 'With...' methods. Do not call
        ///         the constructor at any point in this process.
        ///     </para>
        ///     <para>
        ///         This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///         directly from your code. This API may change or be removed in future releases.
        ///     </para>
        /// </summary>
        /// <param name="databaseCreator"> The database creator. </param>
        /// <param name="rawSqlCommandBuilder"> A command builder for building raw SQL commands. </param>
        /// <param name="connection"> The connection to the database. </param>
        /// <param name="options"> Options for the current context instance. </param>
        /// <param name="modelDiffer"> The model differ. </param>
        /// <param name="migrationsSqlGenerator"> The SQL generator for Migrations operations. </param>
        /// <param name="sqlGenerationHelper"> Helpers for generating update SQL. </param>
        /// <param name="conventionSetBuilder"> The convention set to use when creating the model. </param>
        /// <param name="typeMappingSource"> The type mapper. </param>
        /// <param name="modelLogger"> The logger for model building events. </param>
        public HistoryRepositoryDependencies(
            [NotNull] IRelationalDatabaseCreator databaseCreator,
            [NotNull] IRawSqlCommandBuilder rawSqlCommandBuilder,
            [NotNull] IRelationalConnection connection,
            [NotNull] IDbContextOptions options,
            [NotNull] IMigrationsModelDiffer modelDiffer,
            [NotNull] IMigrationsSqlGenerator migrationsSqlGenerator,
            [NotNull] ISqlGenerationHelper sqlGenerationHelper,
            [NotNull] IConventionSetBuilder conventionSetBuilder,
            [NotNull] IRelationalTypeMappingSource typeMappingSource,
            [NotNull] IDiagnosticsLogger<DbLoggerCategory.Model> modelLogger)
        {
            Check.NotNull(databaseCreator, nameof(databaseCreator));
            Check.NotNull(rawSqlCommandBuilder, nameof(rawSqlCommandBuilder));
            Check.NotNull(connection, nameof(connection));
            Check.NotNull(options, nameof(options));
            Check.NotNull(modelDiffer, nameof(modelDiffer));
            Check.NotNull(migrationsSqlGenerator, nameof(migrationsSqlGenerator));
            Check.NotNull(sqlGenerationHelper, nameof(sqlGenerationHelper));
            Check.NotNull(conventionSetBuilder, nameof(conventionSetBuilder));
            Check.NotNull(typeMappingSource, nameof(typeMappingSource));
            Check.NotNull(modelLogger, nameof(modelLogger));

            DatabaseCreator = databaseCreator;
            RawSqlCommandBuilder = rawSqlCommandBuilder;
            Connection = connection;
            Options = options;
            ModelDiffer = modelDiffer;
            MigrationsSqlGenerator = migrationsSqlGenerator;
            SqlGenerationHelper = sqlGenerationHelper;
            ConventionSetBuilder = conventionSetBuilder;
            TypeMappingSource = typeMappingSource;
            ModelLogger = modelLogger;
        }

        /// <summary>
        ///     The database creator.
        /// </summary>
        public IRelationalDatabaseCreator DatabaseCreator { get; }

        /// <summary>
        ///     A command builder for building raw SQL commands.
        /// </summary>
        public IRawSqlCommandBuilder RawSqlCommandBuilder { get; }

        /// <summary>
        ///     The connection to the database.
        /// </summary>
        public IRelationalConnection Connection { get; }

        /// <summary>
        ///     Options for the current context instance.
        /// </summary>
        public IDbContextOptions Options { get; }

        /// <summary>
        ///     The model differ.
        /// </summary>
        public IMigrationsModelDiffer ModelDiffer { get; }

        /// <summary>
        ///     The SQL generator for Migrations operations.
        /// </summary>
        public IMigrationsSqlGenerator MigrationsSqlGenerator { get; }

        /// <summary>
        ///     Helpers for generating update SQL.
        /// </summary>
        public ISqlGenerationHelper SqlGenerationHelper { get; }

        /// <summary>
        ///     The core convention set to use when creating the model.
        /// </summary>
        public IConventionSetBuilder ConventionSetBuilder { get; }

        /// <summary>
        ///     The type mapper.
        /// </summary>
        public IRelationalTypeMappingSource TypeMappingSource { get; }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IDiagnosticsLogger<DbLoggerCategory.Model> ModelLogger { get; }

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="databaseCreator"> A replacement for the current dependency of this type. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IRelationalDatabaseCreator databaseCreator)
            => new HistoryRepositoryDependencies(
                databaseCreator,
                RawSqlCommandBuilder,
                Connection,
                Options,
                ModelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="rawSqlCommandBuilder"> A replacement for the current dependency of this type. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IRawSqlCommandBuilder rawSqlCommandBuilder)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                rawSqlCommandBuilder,
                Connection,
                Options,
                ModelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="connection"> A replacement for the current dependency of this type. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IRelationalConnection connection)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                connection,
                Options,
                ModelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="options"> A replacement for the current dependency of this type. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IDbContextOptions options)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                Connection,
                options,
                ModelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="modelDiffer"> A replacement for the current dependency of this type. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IMigrationsModelDiffer modelDiffer)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                Connection,
                Options,
                modelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="migrationsSqlGenerator"> A replacement for the current dependency of this type. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IMigrationsSqlGenerator migrationsSqlGenerator)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                Connection,
                Options,
                ModelDiffer,
                migrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="sqlGenerationHelper"> A replacement for the current dependency of this type. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] ISqlGenerationHelper sqlGenerationHelper)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                Connection,
                Options,
                ModelDiffer,
                MigrationsSqlGenerator,
                sqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="conventionSetBuilder"> The core convention set to use when creating the model. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IConventionSetBuilder conventionSetBuilder)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                Connection,
                Options,
                ModelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                conventionSetBuilder,
                TypeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="typeMappingSource"> The type mapper. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IRelationalTypeMappingSource typeMappingSource)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                Connection,
                Options,
                ModelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                typeMappingSource,
                ModelLogger);

        /// <summary>
        ///     Clones this dependency parameter object with one service replaced.
        /// </summary>
        /// <param name="modelLogger"> The type mapper. </param>
        /// <returns> A new parameter object with the given service replaced. </returns>
        public HistoryRepositoryDependencies With([NotNull] IDiagnosticsLogger<DbLoggerCategory.Model> modelLogger)
            => new HistoryRepositoryDependencies(
                DatabaseCreator,
                RawSqlCommandBuilder,
                Connection,
                Options,
                ModelDiffer,
                MigrationsSqlGenerator,
                SqlGenerationHelper,
                ConventionSetBuilder,
                TypeMappingSource,
                modelLogger);
    }
}
